﻿using Models.Implementation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Contracts
{
    public interface ITaxService
    {
        void CalculateTaxes(OrderModel order);
    }
}