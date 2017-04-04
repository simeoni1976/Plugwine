
namespace NLayerProject.BLL.Helpers
{
    /// <summary>
    /// Get price with area
    /// </summary>
    public class OtherPricer : IPricer
    {
        public int Price(int area)
        {
            return area * 4;
        }
    }
}
