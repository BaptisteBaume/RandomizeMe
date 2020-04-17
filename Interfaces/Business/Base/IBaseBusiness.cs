//  ***************************************
//                                                   
//          Bb-RandomizeMe-Core
//                                                   
//  ***************************************
//  Baptiste Baume
//  Copyright (c) BbTech 2020 All Rights Reserved
//  17/04/2020 21:20:04

using Bb.RandomizeMe.Core.Interfaces.Dto;

namespace Bb.RandomizeMe.Core.Interfaces.Business.Base
{
    #region Interfaces

    public interface IBaseBusiness<T> where T : IBusinessResult
    {
    }

    #endregion
}
