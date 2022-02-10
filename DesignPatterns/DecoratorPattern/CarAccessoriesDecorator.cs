namespace DecoratorPattern
{
    public abstract class CarAccessoriesDecorator:ICar
    {
        private ICar car;

        public CarAccessoriesDecorator(ICar car)
        {
            this.car = car;
        }

        public virtual string GetDescription()
        {
            return car.GetDescription();
        }

        public virtual double GetCost()
        {
            return car.GetCost();
        }
    }
}