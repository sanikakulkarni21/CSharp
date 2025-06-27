
namespace  Catalog  {
    public class Product
    {
        private string title;
        private string description;
        private int quantity;
        private float unitPrice;
        private int id; //property for id is not written because property allows to change data


        // readonly property
        // readonly property is used to make sure that the value cannot be changed after it is set
        public int Id
        {
            get { return this.id; }

        }
        public string Title
        {
            get { return this.title; }
            set { this.title = value; }
        }

        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }
        public int Quantity
        {
            get { return this.quantity; }
            set { this.quantity = value; }
        }
        public float UnitPrice
        {
            get { return this.unitPrice; }
            set { this.unitPrice = value; }
        }

        public Product() { }

        public Product(int id, string title, string description, int quantity, float unitPrice)
        {
            this.id = id;
            this.title = title;
            this.description = description;
            this.quantity = quantity;
            this.unitPrice = unitPrice;
        }

        ~Product()
        {
            Console.WriteLine("Product object with id {0} is being destroyed", this.id);
        }

        public override string ToString()
        {
            // return base.Tostring();
            return this.Id + " " + this.Title + " " + this.Description + " " + this.Quantity + " " + this.UnitPrice;
        }


    }
}