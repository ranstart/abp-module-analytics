import { Injectable } from '@angular/core';
import { eLayoutType, addAbpRoutes, ABP } from '@abp/ng.core';
import { addSettingTab } from '@abp/ng.theme.shared';
import { AnalyticsSettingsComponent } from '../components/analytics-settings.component';

@Injectable({
  providedIn: 'root',
})
export class AnalyticsConfigService {
  constructor() {
    addAbpRoutes({
      name: 'Analytics',
      path: 'analytics',
      layout: eLayoutType.application,
      order: 2,
    } as ABP.FullRoute);

    const route = addSettingTab({
      component: AnalyticsSettingsComponent,
      name: 'Analytics Settings',
      order: 1,
      requiredPolicy: '',
    });
  }
}
