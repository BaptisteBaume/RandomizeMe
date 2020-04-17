namespace Bb_RandomizeMe_Core.Dto.Inner
{
    public class InnerResult<T> : BaseDto
    {
        #region Constructors

        public InnerResult(bool result, T iResult, string message = null) : base(result, message)
        {
            IResult = iResult;
        }

        #endregion

        #region Properties

        public T IResult { get; set; }

        #endregion
    }
}
