﻿using LebaneseHomemade.Data.ViewModel;
using LebaneseHomemadeLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LebaneseHomemade.Data.IService
{
    public interface IPhotoService
    {
        List<PhotoModel> GetPhotos(int cardId);
        void AddPhoto(PhotoViewModel photoViewModel);
        int DeletePhoto(int cardId);
        Task<List<PhotoModel>> UpdatePhotos(int cardId,UpdatePhotoViewModel updatePhotoViewModel);
    }
}
