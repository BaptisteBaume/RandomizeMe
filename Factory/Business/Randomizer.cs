//  ***************************************
//                                                   
//          Bb-RandomizeMe-Core
//                                                   
//  ***************************************
//  Baptiste Baume
//  Copyright (c) BbTech 2020 All Rights Reserved
//  17/04/2020 21:20:03

using Bb.RandomizeMe.Core.Business;
using Bb.RandomizeMe.Core.Interfaces.Business;

namespace Bb.RandomizeMe.Core.Factory.Business
{
    public class Randomizer
    {
        public static IRandomizeMe GetRandomizer()
        {
            return new RandomizeMeBusiness();
        }
    }
}
