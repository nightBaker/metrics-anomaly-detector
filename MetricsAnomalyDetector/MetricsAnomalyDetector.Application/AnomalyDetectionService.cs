using MetricsAnomalyDetector.Application.Repositories;
using MetricsAnomalyDetector.Domain;

namespace MetricsAnomalyDetector.Application
{
    public class AnomalyDetectionService
    {
        private readonly ICommandRepository<PredictorInfo> _predictors;
        private readonly ICommandRepository<MetricStorage> _metricStorages;

        public AnomalyDetectionService(ICommandRepository<PredictorInfo> predictors, ICommandRepository<MetricStorage> metricStorages)
        {
            _predictors = predictors;
            _metricStorages = metricStorages;
        }

        public async Task CreateMetricStorage(string name, string url)
        {
            _metricStorages.Add(new MetricStorage(name, url));
            await _metricStorages.UnitOfWork.SaveChangesAsync();
        }

        public async Task CreatePredictor(string name, string metricName, int metricStorageId)
        {
            _predictors.Add(new PredictorInfo(name, metricName, metricStorageId));
            await _predictors.UnitOfWork.SaveChangesAsync();
        }
    }
}
