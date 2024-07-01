using Issatays.StatusCode.Models;
using Microsoft.EntityFrameworkCore;

namespace Issatays.StatusCode;

public class ResultCodeService(Context context)
{
    public MessageByResultCode? GetMessageByResultCode(int code)
    {
        var result = (from rcm in context.ResultCodeMessages
            join rc in context.ResultCodes on rcm.Code equals rc.Code
            where rcm.Code == code
            select new MessageByResultCode()
            {
                Code = rc.Code,
                ClientMessage = rcm.ClientMessage,
                UserMessage = rcm.UserMessage,
                Type = rc.Type,
                Description = rc.Description,
                HttpStatusCode = rc.HttpStatusCode,
                Title = rcm.Title
            }).FirstOrDefault();

        return result;
    }
}