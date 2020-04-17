//  ***************************************
//                                                   
//          Bb-RandomizeMe-Core
//                                                   
//  ***************************************
//  Baptiste Baume
//  Copyright (c) BbTech 2020 All Rights Reserved
//  17/04/2020 21:20:03

namespace Bb.RandomizeMe.Core.Dto
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
