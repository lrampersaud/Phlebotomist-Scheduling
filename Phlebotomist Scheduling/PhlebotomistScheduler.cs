using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phlebotomist_Scheduling
{
    public class PhlebotomistScheduler
    {
        public List<Patient> Patients { get; set; }
        public int PhlebotomistsCount { get; set; }

        public int InitialTemperature { get; set; }
        public float CoolingScheduleAlpha { get; set; }

        public Random Rand { get; set; }
        public int GraspIterations { get; set; }


        public PhlebotomistScheduler(List<Patient> pPatients, int pPhlebotomistsCount, int pInitialTemperature,
            float pCoolingScheduleAlpha, int pGraspIterations)
        {
            Patients = pPatients;
            PhlebotomistsCount = pPhlebotomistsCount;
            InitialTemperature = pInitialTemperature;
            CoolingScheduleAlpha = pCoolingScheduleAlpha;
            GraspIterations = pGraspIterations;
            Rand = new Random();
        }

        private Solution GenerateInitialSolution()
        {
            List<Patient> orderedPatients = this.Patients.OrderBy(p => p.BeginTime).ToList();
            List<List<Patient>> Elements = new List<List<Patient>>();
            for (int i = 0; i < PhlebotomistsCount; i++)
            {
                Elements.Add(new List<Patient>());
                Elements[i].Add(orderedPatients[i]); //Add the first patient to each phlebotomist
            }

            foreach (var item in orderedPatients.Skip(PhlebotomistsCount).ToList())
            {

                //select the one with the highest end time

                if (Elements.Select(p => p.Last()).Any(p => p.EndTime < item.BeginTime))
                {
                    //take phlebotomist with the lowest deadhead time
                    Patient closestPatient = Elements.Select(p => p.Last()).OrderByDescending(p => (item.BeginTime - p.EndTime)).First();

                    //who has the closest patient
                    var phlebotomistWithClosest = Elements.First(p => p.Contains(closestPatient));
                    phlebotomistWithClosest.Add(item);
                }
                else
                {
                    
                    //take phlebotomist with the smallest overlap
                    Patient closestPatient = Elements.Select(p => p.Last()).OrderByDescending(p => (item.BeginTime - p.EndTime)).First();

                    //who has the closest patient
                    var phlebotomistWithClosest = Elements.First(p => p.Contains(closestPatient));
                    phlebotomistWithClosest.Add(item);
                }

            }

            return new Solution(Elements);
        }

        public Solution SimulatedAnnealing(Solution entity)
        {
            Solution current = entity;
            Solution best = current.Clone();
            Solution localBest = current.Clone();
            double T = InitialTemperature;

            while(T > 1)
            {
                current = GenerateNeighbourSolution(current);
                EvaluateSolution(current);
                if (acceptanceProbability(best.Cost, current.Cost, T) > Rand.NextDouble())
                {
                    localBest = current.Clone();
                }
                T *= CoolingScheduleAlpha;
            }
            if (best.Cost > localBest.Cost)
                best = localBest.Clone();
            return best;
        }
        public  double acceptanceProbability(double energy, double newEnergy, double temperature)
        {
            if (newEnergy < energy)
            {
                return 1.0;
            }
            return Math.Exp((energy - newEnergy) / temperature);
        }

        public Solution GenerateNeighbourSolution(Solution entity)
        {
            Solution neighbour = entity.Clone();

            //pick random phlebotomists
            int first = Rand.Next(PhlebotomistsCount);
            int second = Rand.Next(PhlebotomistsCount);

            List<Patient> firstPatients = neighbour.PhlebotomistsList[first];
            List<Patient> secondPatients = neighbour.PhlebotomistsList[second];

            //pick random patient
            int firstPatientPos = Rand.Next(firstPatients.Count);
            int secondPatientPos = Rand.Next(secondPatients.Count);


            //swap patients
            Patient patient1 = firstPatients[firstPatientPos];
            Patient patient2 = secondPatients[secondPatientPos];

           
                firstPatients.Remove(patient1);
                secondPatients.Add(patient1);
            


            
                secondPatients.Remove(patient2);
                firstPatients.Add(patient2);
            


            neighbour.PhlebotomistsList[first] = firstPatients.OrderBy(p => p.BeginTime).ToList();
            neighbour.PhlebotomistsList[second] = secondPatients.OrderBy(p => p.BeginTime).ToList();

            return neighbour;
        }

        public void EvaluateSolution(Solution entity)
        {
            entity.Cost = 0;
            foreach (var patients in entity.PhlebotomistsList)
            {
                for(int i=0; i<patients.Count-1; i++)
                {
                    if (patients[i].EndTime < patients[i + 1].BeginTime)
                    {
                        entity.Cost += (patients[i + 1].BeginTime - patients[i].EndTime).Minutes; //get the difference in minutes
                    }
                    else
                    {
                        entity.Cost += 1000;    //penalty of 1000 minutes for having an overlap
                    }
                }
            }
        }

        public Solution GRASP()
        {
            Solution current;
            Solution best = new Solution();
            best.Cost = double.MaxValue;
            for (int i=0; i<GraspIterations; i++)
            {
                current = GenerateInitialSolution();
                EvaluateSolution(current);
                current = SimulatedAnnealing(current);
                if(current.Cost < best.Cost)
                {
                    best = current.Clone();
                }
            }
            return best;
        }

    }
}
