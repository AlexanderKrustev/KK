namespace KKEcpert.Service
{
    using KKExpert.Data.Interfaces;

    public abstract class Service
    {
        private IKKExpertContext context;

        protected Service(IKKExpertContext _context)
        {
            this.context = _context;
        }

        protected IKKExpertContext Context => this.context;
    }
}
