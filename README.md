# CsvHelperExtensions

Here you can find a generic implementation of a data repository service. Currently, the service supports CSV files, and the data quaries are based on ISpecification<T> interface.

### You have to call:

    var _repositoryService = DataRepositoryService<TreatmentItem, TreatmentItemMapper>.FromCSV(Resource.testdata_multi_records);
    var recordsWithMax12MonthsFolowUpTime = _repositoryService.Get(new WithMaxFollowUpTimeSpec(12));
    var allRecords = repoService.GetAll();
    
### WithMaxFollowUpTimeSpec class

        public class WithMaxFollowUpTimeSpec : ISpecification<TreatmentItem>
    {
        public double MaxFollowUpTimeCutOff { get; }

        public WithMaxFollowUpTimeSpec(double maxFollowUpTimeCutOff)
        {
            MaxFollowUpTimeCutOff = maxFollowUpTimeCutOff;
        }

        public bool IsSatisfiedBy(TreatmentItem subject)
        {
            return subject.FollowUpTimeInMonths < MaxFollowUpTimeCutOff;
        }
    }


### TreatmentItem class

    public class TreatmentItem
    {
        public string Study { get; set; }
        public double TotalPhysicalDoseInGy { get; set; }
        public double Fractions { get; set; }
        public double LocalControlProbability { get; set; }
        public double FollowUpTimeInMonths { get; set; }
        public string PatientId { get; set; }

        public override string ToString()
        {
            return $"{nameof(Study)}: {Study}, {nameof(TotalPhysicalDoseInGy)}: {TotalPhysicalDoseInGy}, {nameof(Fractions)}: {Fractions}, {nameof(LocalControlProbability)}: {LocalControlProbability}, {nameof(FollowUpTimeInMonths)}: {FollowUpTimeInMonths}";
        }
    }

### TreatmentItemMapper class
    public class TreatmentItemMapper : ClassMap<TreatmentItem>
    {
        public TreatmentItemMapper()
        {
            Map(t => t.PatientId).Name("Patient Id");
            Map(t => t.Study).Name("Study");
            Map(t => t.FollowUpTimeInMonths).Name("FollowUpTime(Months)");
            Map(t => t.Fractions).Name("Fractions");
            Map(t => t.TotalPhysicalDoseInGy).Name("TotalPhysicalDose(Gy)");
            Map(t => t.LocalControlProbability).Name("Local Control Probability");
        }
    }

 ### The Resource.testdata_multi_records file includes the following  records:
    Patient Id,Study,FollowUpTime(Months),Fractions,TotalPhysicalDose(Gy),Local Control Probability
    1,high dose,12,1,30,0.88
    2,high dose,13,1,22,0.87
    3,high dose,14,1,28,0.86
    4,high dose,18,1,36,0.95
    5,high dose,25,1,24,0.78
    6,low dose,11,5,10,0.66
    7,low dose,7,6,12,0.67
    8,low dose,6,8,16,0.69
