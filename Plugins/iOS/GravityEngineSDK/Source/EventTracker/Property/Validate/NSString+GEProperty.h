//
//  NSString+GEProperty.h
//  Adjust
//
//

#import <Foundation/Foundation.h>
#import "GEValidatorProtocol.h"

NS_ASSUME_NONNULL_BEGIN

@interface NSString (GEProperty) <GEPropertyKeyValidating, GEPropertyValueValidating>

@end

NS_ASSUME_NONNULL_END
