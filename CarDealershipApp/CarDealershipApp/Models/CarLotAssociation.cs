namespace CarDealershipApp.Models
{
    public class CarLotAssociation
    {
        //******************************************
        // define attributed for car lot association
        //******************************************
        public int AssociationID { get; set; }
        public int CarID { get; set; }
        public int LotID { get; set; }
    }
}
