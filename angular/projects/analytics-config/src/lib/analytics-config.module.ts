import { NgModule, APP_INITIALIZER } from '@angular/core';
import { AnalyticsConfigService } from './services/analytics-config.service';
import { noop } from '@abp/ng.core';
import { AnalyticsSettingsComponent } from './components/analytics-settings.component';

@NgModule({
  declarations: [AnalyticsSettingsComponent],
  providers: [{ provide: APP_INITIALIZER, deps: [AnalyticsConfigService], multi: true, useFactory: noop }],
  exports: [AnalyticsSettingsComponent],
  entryComponents: [AnalyticsSettingsComponent],
})
export class AnalyticsConfigModule {}
