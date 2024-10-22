﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using Repository.Pattern.Repositories;
using System.Threading.Tasks;
using WebApp.Models;
namespace WebApp.Repositories
{
/// <summary>
/// File: BiddingRepository.cs
/// Purpose: The repository and unit of work patterns are intended
/// to create an abstraction layer between the data access layer and
/// the business logic layer of an application.
/// Created Date: 3/8/2020 7:58:02 AM
/// Author: neo.zhu
/// Tools: SmartCode MVC5 Scaffolder for Visual Studio 2017
/// Copyright (c) 2012-2018 All Rights Reserved
/// </summary>
  public static class BiddingRepository  
    {
                 public static async Task<IEnumerable<Bidding>> GetByPurchaseOrderIdAsync(this IRepositoryAsync<Bidding> repository, int purchaseorderid)
          => await repository
                .Queryable()
                .Where(x => x.PurchaseOrderId==purchaseorderid).ToListAsync();
              
          
                 
	}
}



