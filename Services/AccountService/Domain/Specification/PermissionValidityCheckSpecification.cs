﻿using Domain.Repository;
using DomainBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Specification
{
    public class PermissionValidityCheckSpecification : ISpecificationn<Role>
    {
        private readonly IPermissionRepository permissionRepository;
        public PermissionValidityCheckSpecification(IPermissionRepository permissionRepository)
        {
            this.permissionRepository = permissionRepository;
        }
        public async Task<bool> IsSatisfiedBy(Role entity)
        {
            if (entity.Permissions.Any())
            {
                var validPermissions = new List<Guid>();
                var permissionId = entity.Permissions.ToArray();
                await foreach (var permission in permissionRepository.GetManyAsync(permissionId))
                {
                    validPermissions.Add(permission.Id);
                }
                if (entity.Permissions.Except(validPermissions).Any())
                    throw new DomainException("部分所选权限无效!");
            }
            return true;
        }
    }
}