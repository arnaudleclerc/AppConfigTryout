# Playground for Azure App Config

## Current state

This repository contains an Aspire stack containing a Blazor application and a WebApi. Both applications read their configurations from an instance of Azure App Configuration.

## WebAPI

The WebApi reads all keys starting with `Api`. The configuration contains a `Api:Settings:Count` setting defining how many items must be returned by the API.

## Blazor

The blazor application reads all keys starting with `WebApp`. The configuration contains a `WebApp:Settings:BackgroundColor` setting which sets the background color of the application.

## Dynamic configuration

Both applications react to configuration's changes by using the poll model. Each react to the changes of their specific sentinel key. The refresh options of both application have a cache expiration of 5 seconds.

## Todo - When I have time, no rush

- Dynamic configuration using push mode and service bus
- Feature management
- Play with labels
- Play with keyvault references
- And more...