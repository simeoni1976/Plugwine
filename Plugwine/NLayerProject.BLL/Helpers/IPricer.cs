namespace NLayerProject.BLL.Helpers
{
    /// <summary>
    /// Pricer interface
    /// </summary>
    public interface IPricer
    {
        /// <summary>
        /// Get price by area
        /// </summary>
        /// <param name="superficie"></param>
        /// <returns></returns>
        int Price(int superficie);
    }
}