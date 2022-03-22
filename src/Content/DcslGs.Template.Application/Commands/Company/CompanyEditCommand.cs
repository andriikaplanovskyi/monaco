﻿using DcslGs.Template.Common.Application.Commands;

namespace DcslGs.Template.Application.Commands.Company;

public class CompanyEditCommand : CommandBase
{
    protected CompanyEditCommand() {}

    public CompanyEditCommand(Guid id,
                              string name,
                              string email,
                              string webSiteUrl,
                              string address,
                              string city,
                              string county,
                              string postCode,
                              Guid countryId) : base(id)
    {
        Name = name;
        Email = email;
        WebSiteUrl = webSiteUrl;
        Address = address;
        City = city;
        County = county;
        PostCode = postCode;
        CountryId = countryId;
    }

    public string Name { get; private set; }
    public string Email { get; private set; }
    public string WebSiteUrl { get; private set; }
    public string Address { get; private set; }
    public string City { get; private set; }
    public string County { get; private set; }
    public string PostCode { get; private set; }
    public Guid CountryId { get; private set; }
}