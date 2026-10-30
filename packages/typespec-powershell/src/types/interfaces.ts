export interface PSOptions extends Record<string, any> {
  directive?: Array<Record<string, unknown> & {
    "operation-id-mapping"?: Record<string, string>;
  }>;
  packageDetails?: PackageDetails;
  title?: string;
}

export interface PackageDetails {
  name: string;
  scopeName?: string;
  nameWithoutScope?: string;
  description?: string;
  version?: string;
}