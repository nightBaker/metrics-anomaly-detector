namespace MetricsAnomalyDetector.Domain
{
    public interface IPredictor
    {
        Task<AnomalyPrediction> DetectAnomalies(TimeSeriesData[] timeSeries);
    }

    public class TimeSeriesData
    {
        public DateTime Timestamp { get; init; }
        public float Value { get; init; }
    }

    public class AnomalyPrediction
    {        
        public double[] Prediction { get; init; }
    }

    public class PredictorInfo : IAggregateRoot
    {
        public PredictorInfo(string name, string metricName, int metricStorageId)
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

    public class MetricStorage : IAggregateRoot
    {
        public MetricStorage(string name, string url)
        {
            Name = name;
            Url = url;
        }

        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Url { get; private set; }
    }
}
