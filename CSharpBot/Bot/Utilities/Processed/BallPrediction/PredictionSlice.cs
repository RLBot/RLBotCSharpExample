using Bot.Utilities.Processed.Packet;

namespace Bot.Utilities.Processed.BallPrediction
{
    public struct PredictionSlice
    {
        public Physics Physics;
        public float GameSeconds;

        public PredictionSlice(rlbot.flat.PredictionSlice predictionSlice)
        {
            Physics = new Physics(physics: predictionSlice.Physics.Value);
            GameSeconds = predictionSlice.GameSeconds;
        }
    }
}