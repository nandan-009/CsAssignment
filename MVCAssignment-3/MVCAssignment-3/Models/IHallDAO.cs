namespace MVCAssignment_3.Models
{
    public interface IHallDAO
    {
        public List<Hall> GetHall(int price);
    }
}
