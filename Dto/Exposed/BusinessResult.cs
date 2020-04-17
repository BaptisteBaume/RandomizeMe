//  ***************************************
//                                                   
//          Bb-RandomizeMe-Core
//                                                   
//  ***************************************
//  Baptiste Baume
//  Copyright (c) BbTech 2020 All Rights Reserved
//  17/04/2020 21:20:01

using Bb.RandomizeMe.Core.Interfaces.Dto;

namespace Bb.RandomizeMe.Core.Dto.Exposed
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
