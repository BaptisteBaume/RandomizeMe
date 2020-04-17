namespace Bb_RandomizeMe_Core.Dto
{
    public class BaseDto
    {
        #region Constructors

        /// <summary>
        /// Le message est optionnel. Cependant il est conseillé de le renseigner afin de retourner des erreurs ou exceptions
        /// </summary>
        /// <param name="result"></param>
        /// <param name="resultObject"></param>
        /// <param name="message"></param>
        public BaseDto(bool result, string message = null)
        {
            Result = result;
            Message = message;
        }

        #endregion

        #region Properties

        public string Message { get; set; }

        public bool Result { get; set; }

        #endregion
    }
}
