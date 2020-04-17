using Bb_RandomizeMe_Core.Interfaces.Dto;

namespace Bb_RandomizeMe_Core.Dto.Exposed
{
    internal class RepositoryResult<T> : BaseDto, IRepositoryResult
    {
        public T RObject { get; set; }

        public RepositoryResult(bool result, T rObject, string message = null) : base(result, message)
        {
            RObject = rObject;
        }
    }
}
