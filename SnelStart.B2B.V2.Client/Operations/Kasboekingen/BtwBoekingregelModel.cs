namespace SnelStart.B2B.V2.Client.Operations
{
    /// <summary>
    /// Container met gegeven voor een btw boekingsregel
    /// </summary>
    public class BtwBoekingregelModel
    {
        public decimal Debet { get; set; }
        
        public decimal Credit { get; set; }
        
        public BtwTypeModel Type { get; set; }
        
        public BtwTariefModel Tarief { get; set; } 
    }
}