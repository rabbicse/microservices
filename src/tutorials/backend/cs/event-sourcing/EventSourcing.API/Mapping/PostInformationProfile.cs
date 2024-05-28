using AutoMapper;

public class PostInformationProfile : Profile
{
    public PostInformationProfile()
    {
        CreateMap<CreatePostInformationDTO, CreatePostInformationRecord>();
        CreateMap<CreatePostInformationRecord, PostInformation>();
        CreateMap<PostInformation, PostInformationResponseDTO>();
       
    }
}