//  ***************************************
//                                                   
//          Bb-RandomizeMe-Core
//                                                   
//  ***************************************
//  Baptiste Baume
//  Copyright (c) BbTech 2020 All Rights Reserved
//  17/04/2020 21:20:02

namespace Bb.RandomizeMe.Core.Dto.Inner
{
    public class InnerObject<T>
    {
        #region Constructors

        /// <summary>
        /// Transferer un objet entre methodes privées par exemple
        /// </summary>
        /// <param name="innerObj"></param>
        /// <param name="message"></param>
        public InnerObject(T innerObj, string message = null)
        {
            InnerObj = innerObj;
            Message = message;
        }

        #endregion

        #region Properties

        public T InnerObj { get; set; }

        public string Message { get; set; }

        #endregion
    }
}
