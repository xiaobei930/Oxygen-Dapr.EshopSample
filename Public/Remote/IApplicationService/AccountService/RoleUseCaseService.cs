using IApplicationService.AccountService.Dtos.Input;
using Oxygen.Client.ServerSymbol;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace IApplicationService.RoleService
{
    [RemoteService("accountservice", "roleusecase", "��ɫ����")]
    public interface RoleUseCaseService
    {
        [RemoteFunc(funcDescription: "������ɫ")]
        Task<ApiResult> RoleCreate(RoleCreateDto input);

        [RemoteFunc(funcDescription: "���½�ɫ")]
        Task<ApiResult> RoleUpdate(RoleUpdateDto input);
    }
}