﻿using Library.Models;
using Library.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services
{
    class MemberService<T,Tid> : IService
    {
        MemberRepository<T, Tid> _memberRepository;

        public MemberService(RepositoryFactory<T, Tid> repoFactory)
        {
            _memberRepository = repoFactory.GetMemberRepository();
        }

        public event EventHandler Updated;
    }
}