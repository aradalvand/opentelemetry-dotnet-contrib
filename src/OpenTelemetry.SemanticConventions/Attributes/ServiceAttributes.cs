// Copyright The OpenTelemetry Authors
// SPDX-License-Identifier: Apache-2.0

// <auto-generated>This file has been auto generated from 'src\OpenTelemetry.SemanticConventions\scripts\templates\registry\SemanticConventionsAttributes.cs.j2' </auto-generated>

#nullable enable

#pragma warning disable CS1570 // XML comment has badly formed XML

namespace OpenTelemetry.SemanticConventions;

/// <summary>
/// Constants for semantic attribute names outlined by the OpenTelemetry specifications.
/// </summary>
public static class ServiceAttributes
{
    /// <summary>
    /// The string ID of the service instance.
    /// </summary>
    /// <remarks>
    /// MUST be unique for each instance of the same <c>service.namespace,service.name</c> pair (in other words
    /// <c>service.namespace,service.name,service.instance.id</c> triplet MUST be globally unique). The ID helps to
    /// distinguish instances of the same service that exist at the same time (e.g. instances of a horizontally scaled
    /// service).
    /// <p>
    /// Implementations, such as SDKs, are recommended to generate a random Version 1 or Version 4 <a href="https://www.ietf.org/rfc/rfc4122.txt">RFC
    /// 4122</a> UUID, but are free to use an inherent unique ID as the source of
    /// this value if stability is desirable. In that case, the ID SHOULD be used as source of a UUID Version 5 and
    /// SHOULD use the following UUID as the namespace: <c>4d63009a-8d0f-11ee-aad7-4c796ed8e320</c>.
    /// <p>
    /// UUIDs are typically recommended, as only an opaque value for the purposes of identifying a service instance is
    /// needed. Similar to what can be seen in the man page for the
    /// <a href="https://www.freedesktop.org/software/systemd/man/latest/machine-id.html"><c>/etc/machine-id</c></a> file, the underlying
    /// data, such as pod name and namespace should be treated as confidential, being the user's choice to expose it
    /// or not via another resource attribute.
    /// <p>
    /// For applications running behind an application server (like unicorn), we do not recommend using one identifier
    /// for all processes participating in the application. Instead, it's recommended each division (e.g. a worker
    /// thread in unicorn) to have its own instance.id.
    /// <p>
    /// It's not recommended for a Collector to set <c>service.instance.id</c> if it can't unambiguously determine the
    /// service instance that is generating that telemetry. For instance, creating an UUID based on <c>pod.name</c> will
    /// likely be wrong, as the Collector might not know from which container within that pod the telemetry originated.
    /// However, Collectors can set the <c>service.instance.id</c> if they can unambiguously determine the service instance
    /// for that telemetry. This is typically the case for scraping receivers, as they know the target address and
    /// port.
    /// </remarks>
    public const string AttributeServiceInstanceId = "service.instance.id";

    /// <summary>
    /// Logical name of the service.
    /// </summary>
    /// <remarks>
    /// MUST be the same for all instances of horizontally scaled services. If the value was not specified, SDKs MUST fallback to <c>unknown_service:</c> concatenated with <a href="process.md"><c>process.executable.name</c></a>, e.g. <c>unknown_service:bash</c>. If <c>process.executable.name</c> is not available, the value MUST be set to <c>unknown_service</c>.
    /// </remarks>
    public const string AttributeServiceName = "service.name";

    /// <summary>
    /// A namespace for <c>service.name</c>.
    /// </summary>
    /// <remarks>
    /// A string value having a meaning that helps to distinguish a group of services, for example the team name that owns a group of services. <c>service.name</c> is expected to be unique within the same namespace. If <c>service.namespace</c> is not specified in the Resource then <c>service.name</c> is expected to be unique for all services that have no explicit namespace defined (so the empty/unspecified namespace is simply one more valid namespace). Zero-length namespace string is assumed equal to unspecified namespace.
    /// </remarks>
    public const string AttributeServiceNamespace = "service.namespace";

    /// <summary>
    /// The version string of the service API or implementation. The format is not defined by these conventions.
    /// </summary>
    public const string AttributeServiceVersion = "service.version";
}
