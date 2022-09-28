using System;
namespace TechJobsOO

{
    public class TechJob
    {
        
        public int Id { get; }
        private static int nextId = 1;
        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        // TODO: Add the two necessary constructors.
        public TechJob()
        {
            Id = nextId;
            nextId++;
        }

        public TechJob(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) : this()
        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;
        }
        // TODO: Generate Equals() and GetHashCode() methods.
        public override bool Equals(object obj)
        {
            return obj is TechJob job &&
                Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            string jobListing = "\n";
            jobListing += $"\nID: {this.Id}\n";
            
            if (string.IsNullOrEmpty(this.Name))
            {
                jobListing += "Name: Data not available \n";

            }
            else
            {
                jobListing += $"Name: {this.Name}\n";
            }
            if (string.IsNullOrEmpty(this.EmployerName.Value))
            {
                jobListing += "Employer: Data not available \n";
            }
            else
            {
                jobListing += $"Employer: {this.EmployerName}\n";
            }
            if (string.IsNullOrEmpty(this.EmployerLocation.Value))
            {
                jobListing += "Location: Data not available \n";
            }
            else
            {
                jobListing += $"Location: {this.EmployerLocation}\n";
            }
            if (string.IsNullOrEmpty(this.JobType.Value))
            {
                jobListing += "Position Type: Data not available \n";
            }
            else
            {
                jobListing += $"Position Type: {this.JobType}\n";
            }
            if (string.IsNullOrEmpty(this.JobCoreCompetency.Value))
            {
                jobListing += "Core Competency: Data not available \n";
            }
            else
            {
                jobListing += $"Core Competency: {this.JobCoreCompetency}\n";
            }
            return jobListing +="\n";
        }


    }
}