using Nelibur.ObjectMapper;
using System.Collections.Generic;

namespace NLayerProject.Core.Helpers
{
    public static class MappingHelper
    {
        /// <summary>
        /// Mapper
        /// </summary>
        /// <typeparam name="Origin"></typeparam>
        /// <typeparam name="Destination"></typeparam>
        /// <param name="origin"></param>
        /// <returns></returns>
        public static Destination ToMap<Origin, Destination>(this Origin origin)
        {
            return TinyMapper.Map<Destination>(origin);
        }

        /// <summary>
        /// Mapper for lists
        /// </summary>
        /// <typeparam name="Origin"></typeparam>
        /// <typeparam name="Destination"></typeparam>
        /// <param name="origin"></param>
        /// <returns></returns>
        public static IEnumerable<Destination> ToMap<Origin, Destination>(this IEnumerable<Origin> origin)
        {
            return TinyMapper.Map<IEnumerable<Destination>>(origin);
        }
    }
}