import { HttpClient, HttpErrorResponse } from "@angular/common/http";
import { Injectable } from "@angular/core";

@Injectable()
export class MovieOperationService {
    private baseUrl = `http://localhost:21420/api/movie/`;

    constructor(private _http: HttpClient) {}

    getAllMovies() {
        const endPoint = this.baseUrl + `get-all-movies`;
        return this._http.get(endPoint);
    }
}