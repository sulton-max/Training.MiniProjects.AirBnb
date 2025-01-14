import type ApiClientBase from "@/infrastructures/apiClients/apiClientBase/ApiClientBase";
import type { Listing } from "@/modules/locations/models/Listing";
import type { ListingFilter } from "@/modules/locations/models/ListingFilter";

export class ListingsEndpointClient {
    private client: ApiClientBase;

    constructor(client: ApiClientBase) {
        this.client = client;
    }

    public async getAsync(filter: ListingFilter) {
        const queryString = filter.convertToQueryParams();
        return await this.client.getAsync<Array<Listing>>(`api/listings${queryString}`);
    }
}