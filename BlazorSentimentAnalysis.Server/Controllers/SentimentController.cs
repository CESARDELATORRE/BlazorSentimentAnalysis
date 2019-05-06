using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorSentimentAnalysis.Server.ML.DataModels;
using Microsoft.Extensions.ML;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorSentimentAnalysis.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SentimentController : ControllerBase
    {
        private readonly PredictionEnginePool<ModelInput, ModelOutput> _predictionEnginePool;

        public SentimentController(PredictionEnginePool<ModelInput, ModelOutput> predictionEnginePool)
        {
            // Get the ML Model Engine injected, for scoring
            _predictionEnginePool = predictionEnginePool;
        }

        [HttpGet("[action]")]
        [Route("sentimentprediction")]
        public ActionResult<float> PredictSentiment([FromQuery]string sentimentText)
        {
            string sampleText = sentimentText;

            // Predict sentiment using ML.NET model
            //ModelInput sampleData = new ModelInput() { Text = sentimentText };
            ////Predict sentiment
            //ModelOutput prediction = _predictionEnginePool.Predict(sampleData);
            //float percentage = CalculatePercentage(prediction.Score);

            // Random simulation
            Random random = new Random();
            float percentage = random.Next(0, 100);

            return percentage;
        }

        public float CalculatePercentage(double value)
        {
            return 100 * (1.0f / (1.0f + (float)Math.Exp(-value)));
        }
    }
}