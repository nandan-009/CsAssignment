namespace MVCAssignment_3.Models
{
    public class HallDAO : IHallDAO
    {
        private readonly HallDBContext dbCtx;
        public HallDAO(HallDBContext dbCtx)
        {
            this.dbCtx = dbCtx;
        }

        public List<Hall> GetHall(int price)
        {
            List<Hall> halls = new List<Hall>();

            List<Hall> hall1 = dbCtx.Halls.ToList();

            foreach (var item in hall1)
            {
                if (item.CostPerDay <= price)
                {
                    halls.Add(item);
                }
            }
            return halls;
        }
    }
}
