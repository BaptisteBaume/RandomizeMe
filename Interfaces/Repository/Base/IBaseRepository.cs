//  ***************************************
//                                                   
//          Bb-RandomizeMe-Core
//                                                   
//  ***************************************
//  Baptiste Baume
//  Copyright (c) BbTech 2020 All Rights Reserved
//  17/04/2020 21:20:06

using Bb.RandomizeMe.Core.Interfaces.Dto;

namespace Bb.RandomizeMe.Core.Interfaces.Repository.Base
{
    #region Interfaces

    public interface IBaseRepository<T> where T : IRepositoryResult
    {
    }

    #endregion
}
