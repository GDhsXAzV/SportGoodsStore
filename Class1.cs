namespace SportGoodsStore.Goods
{
    public abstract class StoreItem
    {
        public StoreItem(string name, string type, string description)
        {
            Name = name;
            Type = type;
            Description = description;
        }
        public abstract string Name { get; init; }
        protected virtual int Id { get; init; }
        public abstract string Type { get; init; }
        public abstract string Description { get; init; }
    }

    internal interface IHasShelfLife
    {
        bool HasShelfLife { get; }
        bool SearchForExpirationDate();
        DateTime ProductionDate { get; init; }
    }

    public abstract class Wear : StoreItem
    {
        public Wear(string name, string type, string description) : base(name, type, description)
        {      }
        public override string Name => "Wear";
        protected override int Id => 0;
        public override string Type => "Wear";
        public override string Description => "Wearables";
    }
    public abstract class Tshirt : Wear
    {
        public Tshirt(string name, string type, string description) : base(name, type, description)
        { }
        public override string Name => "Tshirt";
        protected override int Id => 1;
        public override string Type => "Tshirt";
        public override string Description => "Tshirt for your wearable needs";
    }
    public abstract class Shorts : Wear
    {
        public Shorts(string name, string type, string description) : base(name, type, description)
        { }
        public override string Name => "Shorts";
        protected override int Id => 2;
        public override string Type => "Shorts";
        public override string Description => "Shorts for your wearable needs";
    }
    public abstract class Equipment : StoreItem
    {
        public Equipment(string name, string type, string description) : base(name, type, description)
        { }
        public override string Name => "Equipment";
        protected override int Id => 0;
        public override string Type => "Equipment";
        public override string Description => "Equipment";
    }
    public abstract class Dumbbells : Equipment
    {
        public Dumbbells(string name, string type, string description) : base(name, type, description)
        { }
        public override string Name => "Dumbbells";
        protected override int Id => 1;
        public override string Type => "Equipment";
        public override string Description => "Dumbbells for your weight needs";

    }
    public abstract class RunningBoard : Equipment
    {
        public RunningBoard(string name, string type, string description) : base(name, type, description)
        { }
        public override string Name => "RunningBoard";
        protected override int Id => 2;
        public override string Type => "Equipment";
        public override string Description => "RunningBoard for your running needs";

    }
    public abstract class Food : StoreItem, IHasShelfLife
    {
        public Food(string name, string type, string description, DateTime productionDate) : base(name, type, description)
        {
            ProductionDate = productionDate;
        }
        public override string Name => "Food";
        protected override int Id => 0;
        public override string Type => "Food";
        public override string Description => "Food";

        public bool HasShelfLife => true;

        public DateTime ProductionDate { get; init; }

        public DateTime ExpirationDate;

        public bool SearchForExpirationDate()
        {
            return true;
        }
    }
    public abstract class EnergyBar : Food
    {
        
        public EnergyBar(string name, string type, string description, DateTime productionDate) : base(name, type, description, productionDate)
        { 
            //ProductionDate = productionDate;
        }
        public DateTime ProdictionDate { get; init; }
        public override string Name => "EnergyBar";
        protected override int Id => 1;
        public override string Description => "Nutrition for your activities";
        public bool HasShelfLife => true;
        public bool SearchForExpirationDate()
        {
            return true;
        }

    }
}
