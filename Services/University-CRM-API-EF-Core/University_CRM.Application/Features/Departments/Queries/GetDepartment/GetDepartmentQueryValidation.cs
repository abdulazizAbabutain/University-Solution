using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_CRM.Application.Features.Departments.Queries.GetDepartment
{
    public class GetDepartmentQueryValidation : AbstractValidator<GetDepartmentQuery>
    {
        public GetDepartmentQueryValidation()
        {
            RuleFor(r => r.Id)
                .NotEmpty()
                .GreaterThanOrEqualTo(1).WithMessage("must be postive value");
        }
    }
}
