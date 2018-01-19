namespace CommonAssemblyInfo.Domain
{
    public class TaxCalculationCommand
    {
        private readonly TaxCalculationInputModel _model;

        public TaxCalculationCommand(TaxCalculationInputModel model)
        {
            _model = model;
        }

        public decimal Execute()
        {
            return _model.Amount * _model.TaxRate / 100M;
        }
    }
}