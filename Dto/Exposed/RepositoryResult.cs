//  ***************************************
//                                                   
//          Bb-RandomizeMe-Core
//                                                   
//  ***************************************
//  Baptiste Baume
//  Copyright (c) BbTech 2020 All Rights Reserved
//  17/04/2020 21:20:02

using Bb.RandomizeMe.Core.Interfaces.Dto;

namespace Bb.RandomizeMe.Core.Dto.Exposed
{
    internal class RepositoryResult<T> : BaseDto, IRepositoryResult
    {
        #region Constructors

        public RepositoryResult(bool result, T rObject, string message = null) : base(result, message)
        {
            RObject = rObject;
        }

        #endregion

        #region Properties

        public T RObject { get; set; }

        #endregion
    }
}
