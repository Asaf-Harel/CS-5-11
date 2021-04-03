using System;
namespace Application
{
    public class Waiting
    {
        private double dfHead;
        private bool hasMask;

        public Waiting(double dfHead, bool hasMask)
        {
            this.dfHead = dfHead;
            this.hasMask = hasMask;
        }

        public double GetDfHead() { return dfHead; }
        public bool GetHasMask() { return hasMask; }
    }
}
