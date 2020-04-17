using Bb_RandomizeMe_Core.Interfaces.Dto;

namespace Bb_RandomizeMe_Core.Dto.Exposed
{
    public class BusinessResult<T> : BaseDto, IBusinessResult
    {
        #region Constructors

        public BusinessResult(bool result, T bObject, string message = null) : base(result, message)
        {
            BObject = bObject;
        }

        #endregion

        #region Properties

        public T BObject { get; set; }

        #endregion
    }
}
