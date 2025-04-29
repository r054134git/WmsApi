public string WriteCode()
{
    CodeBuilder.Clear();
	
	CodeBuilder.Append("using AutoMapper;").AppendLine();
    CodeBuilder.Append("using FluentValidation;").AppendLine();
	CodeBuilder.Append("using Microsoft.AspNetCore.Mvc;").AppendLine();
	CodeBuilder.Append("using WmsApi.Contracts.Models;").AppendLine();
	CodeBuilder.Append("using WmsApi.Domain;").AppendLine();
	CodeBuilder.Append("using WmsApi.Domain.Entities;").AppendLine();
	CodeBuilder.AppendLine();

	CodeBuilder.Append("namespace WmsApi.Controllers").AppendLine();
	CodeBuilder.Append("{").AppendLine();
	using (CodeBuilder.Indent())
	{
		CodeBuilder.Append("[ApiController]").AppendLine();
		CodeBuilder.Append("[Route(\"[controller]\")]").AppendLine();

		CodeBuilder.Append($"public class {Entity.EntityClass}Controller : EntityControllerBase<{Entity.EntityClass}, {Entity.EntityClass}ReadModel, {Entity.EntityClass}CreateModel, {Entity.EntityClass}UpdateModel>").AppendLine();
		CodeBuilder.Append("{").AppendLine();
			using (CodeBuilder.Indent())
			{
			CodeBuilder.Append($"public {Entity.EntityClass}Controller(WmspcrContext dataContext, IMapper mapper, IValidator<{Entity.EntityClass}CreateModel> createValidator, IValidator<{Entity.EntityClass}UpdateModel> updateValidator)").AppendLine();
			using (CodeBuilder.Indent())
			{
				CodeBuilder.Append(": base(dataContext, mapper, createValidator, updateValidator)").AppendLine();
			}
			CodeBuilder.Append("{").AppendLine();

			CodeBuilder.Append("}").AppendLine();
		}
		CodeBuilder.Append("}").AppendLine();
	}
	CodeBuilder.Append("}").AppendLine();

    return CodeBuilder.ToString();
}


// run script
WriteCode()