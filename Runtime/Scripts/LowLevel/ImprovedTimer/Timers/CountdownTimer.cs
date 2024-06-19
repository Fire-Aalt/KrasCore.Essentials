namespace RenderDream.GameEssentials
{
    /// <summary>
    /// Timer that counts down from a specific value to zero.
    /// </summary>
    public class CountdownTimer : Timer
    {
        public CountdownTimer(float duration = 0, bool isManual = false, bool useUnscaledTime = false) : base(isManual, useUnscaledTime) 
        {
            initialTime = duration;
        }

        public void Start(float duration)
        {
            initialTime = duration;
            Start();
        }

        public override void Tick()
        {
            if (IsRunning && CurrentTime > 0)
            {
                CurrentTime -= DeltaTime;
            }

            if (IsRunning && CurrentTime <= 0)
            {
                Stop();
            }
        }

        public override bool IsFinished => CurrentTime <= 0;
    }
}
