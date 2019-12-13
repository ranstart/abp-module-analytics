export const environment = {
  production: false,
  hmr: false,
  application: {
    name: 'Analytics',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44397',
    clientId: 'Analytics_ConsoleTestApp',
    dummyClientSecret: '1q2w3e*',
    scope: 'Analytics',
    showDebugInformation: true,
    oidc: false,
    requireHttps: true,
  },
  apis: {
    default: {
      url: 'https://localhost:44355',
    },
  },
  localization: {
    defaultResourceName: 'Analytics',
  },
};
