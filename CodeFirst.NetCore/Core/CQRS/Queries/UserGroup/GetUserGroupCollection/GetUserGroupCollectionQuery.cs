﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirst.NetCore
{
    public class GetUserGroupCollectionQuery : IRequest<IEnumerable<UserGroup>>
    {

    }
}
