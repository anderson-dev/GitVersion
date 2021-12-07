using GitVersion.Extensions;

namespace GitVersion.VersionCalculation;

public class VersionStrategyBase : IVersionStrategy
{
    private readonly Lazy<GitVersionContext> versionContext;
    protected GitVersionContext Context => this.versionContext.Value;

    protected VersionStrategyBase(Lazy<GitVersionContext> versionContext) => this.versionContext = versionContext.NotNull();
    public virtual IEnumerable<BaseVersion> GetVersions() => throw new NotImplementedException();
}
