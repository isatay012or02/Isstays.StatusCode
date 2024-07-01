using Issatays.StatusCode.Models;

namespace Issatays.StatusCode;

public interface IResultCodeService
{
    MessageByResultCode? GetMessageByResultCode(int code);
}