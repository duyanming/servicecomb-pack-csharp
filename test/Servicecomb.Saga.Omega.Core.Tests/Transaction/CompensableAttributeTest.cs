﻿using System;
using System.Collections.Generic;
using System.Text;
using Servicecomb.Saga.Omega.Core.Connector.GRPC;
using Servicecomb.Saga.Omega.Core.Context;
using Servicecomb.Saga.Omega.Core.Transaction;
using Servicecomb.Saga.Omega.Core.Transaction.Impl;
using Servicecomb.Saga.Omega.Protocol;
using Xunit;

namespace Servicecomb.Saga.Omega.Core.Tests.Transaction
{
    
    public class CompensableAttributeTest
    {
        [Fact]
        public void CanCompensable()
        {
            var aTest = new Test();
            aTest.ExcuteBusiness();
        }
    }

    public class Test
    {
        [Compensable(1, "DoSomething",1,50)]
        public void ExcuteBusiness()
        {

        }

        private string DoSomething()
        {
            return "doSomething";
        }
    }

    
}
