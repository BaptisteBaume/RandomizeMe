//  ***************************************
//                                                   
//          Bb-RandomizeMe-Core
//                                                   
//  ***************************************
//  Baptiste Baume
//  Copyright (c) BbTech 2020 All Rights Reserved
//  17/04/2020 21:20:03

namespace Bb.RandomizeMe.Core.Dto.Inner
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
