﻿using Common;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IPetService
    {
        Response Insert(Pet p);
        DataResponse<Pet> GetAll();

    }
}
