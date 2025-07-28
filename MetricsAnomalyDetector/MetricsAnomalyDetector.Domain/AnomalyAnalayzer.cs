namespace MetricsAnomalyDetector.Domain
{
    public class AnomalyAnalayzer : IAggregateRoot
    {
        public AnomalyAnalayzer(string name, string metricName, int metricStorageId)
        {
            Name = name;
            MetricName = metricName;
            MetricStorageId = metricStorageId;
            
        }

        public int Id { get; private set; }

        public string Name { get; private set; }

        public string MetricName { get; private set; }

        public int MetricStorageId { get; private set; }

    }
}
