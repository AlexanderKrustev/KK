namespace KKEcpert.Service
{
    using KKExpert.Data;

    public abstract class Service
    {
        private KKExpertContext context;

        protected Service()
        {
            this.context= new KKExpertContext();
        }

        protected KKExpertContext Context => this.context;
    }
}
