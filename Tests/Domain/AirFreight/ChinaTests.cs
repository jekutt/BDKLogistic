﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using SemestriProject.Data.AirFreight;
using SemestriProject.Domain.AirFreight;
using SemestriProject.Domain.Common;

namespace SemestriProject.Tests.Domain.AirFreight
{
    [TestClass]
    public class ChinaTests : SealedClassTests<China, Entity<ChinaData>> { }
}
